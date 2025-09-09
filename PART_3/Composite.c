#include<stdio.h>
#include<string.h>
#define MAX_SIZE 100
int size = 0;
char keys[MAX_SIZE][100];
float values[MAX_SIZE];
int getIndex(char key[]) {
    for (int i = 0; i < size; i++) {
        if (strcmp(keys[i], key) == 0) {
            return i;
        }
    }
    return -1;
}

void dictInsert(char key[], float value) {
    int idx = getIndex(key);
    if (idx == -1 && size < MAX_SIZE) {
        strcpy(keys[size], key);
        values[size] = value;
        size++;
    } else if (idx != -1) {
        values[idx] = value;
    }
}

float dictGet(char key[]) {
    int idx = getIndex(key);
    if (idx != -1) {
        return values[idx];
    }
    return 0.0f; 
}

void dictPrint() {
    printf("Diccionario:\n");
    for (int i = 0; i < size; i++) {
        printf("%s: %.2f\n", keys[i], values[i]);
    }
}

struct Car{
    char engine[15];
    char tyres[20];
};

int main() {
    dictInsert("Pablo", 1);
    dictInsert("Luisa", 5);
    dictInsert("Castri", 4.8);
    dictInsert("Sebas", 4.8);
    dictInsert("Daniel", 4.81);
    dictPrint();
    char names[5][10] = {"Pablo", "Luisa", "Castri", "Sebas", "Daniel"};
    for (int i = 0; i < 5; i++) {
        printf("%s\n", names[i]);
    }
    struct Car rb19;
    strcpy(rb19.engine, "Honda");
    strcpy(rb19.tyres, "Pirelli P Zero C4");
    printf("Engine: %s\n", rb19.engine);
    printf("Tyres: %s\n", rb19.tyres);
    return 0;
}