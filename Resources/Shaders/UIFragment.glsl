#version 330


uniform vec4 fillColor;

out vec4 framebufferColor;

void main() {
    framebufferColor = fillColor;
}