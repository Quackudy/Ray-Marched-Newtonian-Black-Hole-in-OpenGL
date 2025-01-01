cmake_minimum_required(VERSION 3.10)

# Project name
project(Ray-Marched-Newtonian-Black-Hole-in-OpenGL)

# Set the C++ standard
set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

# Include directories
include_directories("${CMAKE_SOURCE_DIR}/libraries/include")

# Linker directories
link_directories("${CMAKE_SOURCE_DIR}/libraries/lib")

# Asset file
file(COPY ${CMAKE_SOURCE_DIR}/asset DESTINATION ${CMAKE_BINARY_DIR})

# Shader file
file(COPY ${CMAKE_SOURCE_DIR}/shader DESTINATION ${CMAKE_BINARY_DIR})

# Source files
set(SOURCES
    Application.cpp
    camera.cpp
    glad.c
    shader.cpp
    stb_image.cpp
    shader/shader.vs
    shader/shader.fs
    shader.h
    camera.h
)


# Add executable
add_executable(${PROJECT_NAME} ${SOURCES})

# Link libraries
target_link_libraries(${PROJECT_NAME}
    glfw3
    opengl32
    User32
    gdi32
    Shell32
)

# Debugging output
message(STATUS "Include directories: ${CMAKE_SOURCE_DIR}/libraries/include")
message(STATUS "Library directories: ${CMAKE_SOURCE_DIR}/libraries/lib")
