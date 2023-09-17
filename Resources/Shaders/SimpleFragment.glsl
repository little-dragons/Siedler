#version 330

in vec3 pos;

out vec4 color;
void main() {
    color = vec4(pos + vec3(0.5), 1.0);
}