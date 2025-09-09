
#include <stdio.h>
#include <string.h>

union Data {
    int integer;
    float floating;
    char text[20];
};

struct Variant {
    int type; // 0: int, 1: float, 2: string
    union {
        int integer;
        float floating;
        char text[20];
    } value;
};

int main() {
    union Data d;
    d.integer = 42;
    printf("Integer: %d\n", d.integer);
    d.floating = 3.14f;
    printf("Floating: %.2f\n", d.floating);
    strcpy(d.text, "Hello");
    printf("Text: %s\n", d.text);

    struct Variant v;
    v.type = 1;
    v.value.floating = 7.5f;
    if (v.type == 0)
        printf("Variant integer: %d\n", v.value.integer);
    else if (v.type == 1)
        printf("Variant floating: %.2f\n", v.value.floating);
    else if (v.type == 2)
        printf("Variant text: %s\n", v.value.text);

    return 0;
}
