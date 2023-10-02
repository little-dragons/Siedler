#version 330

layout(location = 0) in vec3 coord;
layout(location = 1) in vec2 inTexCoord;

uniform mat4 projection;
uniform mat4 view;
uniform mat4 model;

mat4 mvp = projection * view * model;
mat4 mv = view * model;

out vec3 pos;
out vec2 texCoord;

void main() {
    texCoord = inTexCoord;

    pos = (mv * vec4(coord, 1.0)).xyz;

    gl_Position = mvp * vec4(coord, 1.0);
}