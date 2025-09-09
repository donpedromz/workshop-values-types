package PART_5;

public class Recursive {
    public static class Node{
        private Node next;
        private int value;
        public Node(int value){
            this.value = value;
            this.next = null;
        }
    }
    public static class BNode{
        private BNode left;
        private BNode right;
        private int value;
        public BNode(int value){
            this.value = value;
            this.left = null;
            this.right = null;
        }
        public BNode getRight(){
            return this.right;
        }
        public BNode getLeft(){
            return this.left;
        }
        public int getValue(){
            return this.value;
        }
        public void setLeft(int value){
            this.left = new BNode(value);
        }
        public void setRight(int value){
            this.right = new BNode(value);
        }
    }
    public static class BTree{
        private BNode root;
        public BTree(){
            this.root = null;
        }
        private void recursive_insert(BNode node, int value){
            if(node.getValue() >= value){
                if(node.getLeft() == null){
                    node.setLeft(value);
                }else{
                    recursive_insert(node.getLeft(), value);
                }
            }else{
                if(node.getRight() == null){
                    node.setRight(value);
                }else{
                    recursive_insert(node.getRight(), value);
                }
            }
        }
        private void recursive_in_order(BNode node){
            if(node != null){
                recursive_in_order(node.getLeft());
                System.out.print(node.getValue() + "\t");
                recursive_in_order(node.getRight());
            }
        }
        public void in_order(){
            if(this.root == null){
                System.out.println("Empty Btree");
                return;
            }
            recursive_in_order(this.root);
        }
        public void insert(int value){
            if(this.root == null){
                this.root = new BNode(value);
                return;
            }
            recursive_insert(root, value);
        }
    }
    public static class LinkedList{
        private Node head;
        private int lenght;
        public LinkedList(){
            this.head = null;
            this.lenght = 0;
        }
        public void push(int value){
            if(this.head == null){
                this.head = new Node(value);
                this.lenght++;
                return;
            }
            Node current = this.head;
            while(current.next != null){
                current = current.next;
            }
            current.next = new Node(value);
        }
        public void traverse(){
            if(this.head.equals(null)){
                System.out.println("Empty Linked List");
                return;
            }
            Node current = this.head;
            while(current != null){
                System.out.print(current.value + "--->");
                current = current.next;
            }
            System.out.println("null");
        }

        public static void main(String[] args) {
            // Linked List
            LinkedList list = new LinkedList();
            list.push(10);
            list.push(20);
            list.push(30);
            list.traverse();
            // Binary Tree
            BTree tree = new BTree();
            tree.insert(10);
            tree.insert(-4);
            tree.insert(11);
            tree.insert(24);
            tree.insert(-6);
            tree.in_order();
        }
    }
}
