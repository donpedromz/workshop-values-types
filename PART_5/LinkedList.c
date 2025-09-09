#include <stdio.h>
#include <stdlib.h>
struct Node {
    int data;
    struct Node* next;
};
void push(struct Node** head_ref, int new_data) {
     struct Node* new_node = (struct Node*)malloc(sizeof(struct Node));
    new_node->data = new_data;
    new_node->next = NULL;
    if (*head_ref == NULL) {
        *head_ref = new_node;
        return;
    }
    struct Node* current = *head_ref;
    while (current->next != NULL) {
        current = current->next;
    }
    current->next = new_node;
}
void traverse(struct Node* head) {
    struct Node* current = head;
    while (current != NULL) {
        printf("%d -> ", current->data);
        current = current->next;
    }
    printf("NULL\n");
}
int main() {
    struct Node* head = NULL;
    push(&head, 10);
    push(&head, 20);
    push(&head, 30);
    printf("Lista enlazada: \n");
    traverse(head);
    return 0;
}