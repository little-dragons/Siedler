#version 330

layout(location = 0) in vec3 coord;
layout(location = 1) in vec2 inTexCoord;

uniform mat4 proj;

out vec3 pos;
out vec2 texCoord;

void main() {
    texCoord = inTexCoord;

    pos = coord;
    vec3 rot = (proj * vec4(coord, 1.0)).xyz;
    gl_Position = vec4(rot, 1.0);
}