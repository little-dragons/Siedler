#version 330

layout(location = 0) in vec3 coord;

uniform mat4 proj;

out vec3 pos;

void main() {
    pos = coord;
    vec3 rot = (proj * vec4(coord, 1.0)).xyz;
    gl_Position = vec4(rot, 1.0);
}