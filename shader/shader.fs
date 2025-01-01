#version 330 core
out vec4 FragColor;

in vec3 TexCoords;

uniform samplerCube skybox;
uniform vec3 camPos;

// Raymarching parameters
const float MAX_DISTANCE = 300.0;
const float MIN_DISTANCE = 0.001;
const int MAX_STEPS = 200;

// Sphere parameters
const vec3 sphereCenter = vec3(0.0, 0.0, -10.0);
const float sphereRadius = 1.0;

float sphereSDF(vec3 point) {
    // Signed distance function
    return length(point - sphereCenter) - sphereRadius;
}


vec3 rayMarch(vec3 origin, vec3 direction) {
    float totalDistance = 0.0;
    vec3 currentPosition = origin; // Start at the origin

    for (int i = 0; i < MAX_STEPS; i++) {
        float distance = sphereSDF(currentPosition);

        //Newton law
        vec3 toSphereCenter = sphereCenter - currentPosition;
        direction += (1.0 / pow(length(toSphereCenter), 2.0)) * normalize(toSphereCenter)*2;
        direction = normalize(direction);


        currentPosition += direction * distance;
        totalDistance += distance;

        if (totalDistance > MAX_DISTANCE) {
            break;
        }
    }

    if (length(currentPosition-sphereCenter) < 10.0f) {
        return vec3(1.0f,1.0f,1.0f);
    }

    return direction; // No intersection
}



void main() {
    vec3 rayOrigin = vec3(camPos); //origin
    vec3 rayDirection = normalize(TexCoords);

    //ray marching
    vec3 rayVec = rayMarch(rayOrigin, rayDirection);

    if (length(rayVec) > 1.1) {
        // If hit the sphere, set color to black
        FragColor = vec4(0.0, 0.0, 0.0, 1.0);
    } else {
        // Otherwise, sample from the skybox
        FragColor = texture(skybox, rayVec);
    }
}
