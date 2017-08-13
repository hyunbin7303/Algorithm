
public class BST {
	
	Node root;
	public class Node{
		int data;
		Node left;
		Node right;
		public Node(int data) {
			this.data = data;
			left = null;
			right = null;
		}
	}

	BST(){
		root = null;
	}
	
	void add(int num) {
		// if there is nothing in the node.
		root = addRecursion(root, num);
	}

	private Node addRecursion(Node newRoot, int num) {
		if(newRoot ==null) {
			newRoot = new Node(num);
			return newRoot;
		}
		
		else if(num < newRoot.data) {
			newRoot.left = addRecursion(newRoot.left, num);
		}
		else if(num > newRoot.data) {
			newRoot.right = addRecursion(newRoot.right, num);
		}
		return newRoot;
	}
	
	
	
	void preorder(Node root) {
		if(root!= null) {
			System.out.println(root.data);
			preorder(root.left);
			preorder(root.right);
		}
	}
	void inorder(Node root) {
		if(root != null) {
			inorder(root.left);
			System.out.println(root.data);
			inorder(root.right);
		}
	}
	void postorder(Node root) {
		if(root != null) {
			postorder(root.left);
			postorder(root.right);
			System.out.println(root.data);
		}
	}
	
	public static void main(String[] args) {
		BST a = new BST();
		a.add(10);
		a.add(1);
		a.add(5);
		a.add(20);
		a.add(30);
		a.add(8);
		a.add(25);
		System.out.println("INORDER : ");
		a.inorder(a.root);
		
		System.out.println();
		System.out.println("PREORDER : ");
		a.preorder(a.root);

		System.out.println();
		System.out.println("POSTORDER : ");
		a.postorder(a.root);
	}
	
	
}
