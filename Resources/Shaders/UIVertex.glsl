#version 330

layout (location = 0) in vec2 percent;
layout (location = 1) in vec2 offset;

uniform ivec2 windowsize;



void main() {
    gl_Position = vec4(percent + (offset * 2 / windowsize), 0.0, 1.0);
}
