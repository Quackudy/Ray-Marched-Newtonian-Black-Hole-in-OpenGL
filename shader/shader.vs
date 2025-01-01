#version 330 core
layout(location = 0) in vec3 aPos;

out vec3 TexCoords;

uniform mat4 projection;
uniform mat4 view;

void main()
{
    TexCoords = vec3(aPos.x, aPos.y, aPos.z);  // Pass the vertex position as texture coordinates
    vec4 pos = projection * view * vec4(aPos, 1.0f);
    gl_Position = vec4(pos.x, pos.y, pos.w, pos.w); //make z always 1 to make it behind everything
}
