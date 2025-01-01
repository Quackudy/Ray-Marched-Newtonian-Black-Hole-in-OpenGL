cmake_minimum_required(VERSION 3.10)

# Project name
project(MyOpenGLProject)

# Set the C++ standard
set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

# Include directories
include_directories("${CMAKE_SOURCE_DIR}/libraries/include")

# Linker directories
link_directories("${CMAKE_SOURCE_DIR}/libraries/lib")

# Source files
set(SOURCES
    src/Main.cpp # Add your source files here
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
