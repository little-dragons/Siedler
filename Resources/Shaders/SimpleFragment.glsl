#version 330

in vec3 pos;
in vec2 texCoord;

uniform sampler2D tex;

out vec4 color;
void main() {
    color = texture(tex, texCoord);
    // color = vec4(texCoord, 1.0, 1.0);
}