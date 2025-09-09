#include<stdio.h>
#include<string.h>
//Dict implementation
const int MAX_SIZE = 100;
int size = 0;
char keys[MAX_SIZE][100];
float values[MAX_SIZE];
int getIndex(char key[]){
    for(int i = 0; i < size; i++){
        if(strcmp(keys[i],key) == 0){
            return i;
        }
    }
    return -1;
}

struct Car{
    char engine[15];
    char tyres[20];
};
int main(){
    char names[5][10] = {"Pablo", "Luisa",
        "Castri","Sebas","Daniel"
    };
    for(int i = 0; i < 5; i++){
        printf("%s\n",names[i]);
    }
    struct Car rb19;
    strcpy(rb19.engine, "Honda");
    strcpy(rb19.tyres, "Pirelli P Zero C4");
    printf("Engine: %s\n",rb19.engine);
    printf("Tyres: %s\n",rb19.tyres);
    return 0;
}