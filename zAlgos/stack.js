/**
 * Class to represent a stack using an array to store the stacked items.
 * Follows a LIFO (Last In First Out) order where new items are stacked on
 * top (back of array) and removed items are removed from the top / back.
 */
 class Stack {
    /**
     * The constructor is executed when instantiating a new Stack() to construct
     * a new instance.
     * @returns {Stack} This new Stack instance is returned without having to
     *    explicitly write 'return' (implicit return).
     */
    constructor() {
        this.items = [];
    }

    /**
     * Adds a new given item to the top / back of this stack.
     * - Time: O(1) constant.
     * - Space: O(1) constant.
     * @param {any} item The new item to be added to the top / back.
     * @returns {number} The new length of this stack.
     */
    push(item) { 
        // this.items is the array representing our stack, and so we can use the array's
        // built in push command
        this.items.push(item);
        return this.items.length;
    }

    /**
     * Removes the top / last item from this stack.
     * - Time: O(1) constant.
     * - Space: O(1) constant.
     * @returns {any} The removed item or undefined if this stack was empty.
     */
    pop() { 
        return this.items.pop();
    }

    /**
     * Retrieves the top / last item from this stack without removing it.
     * - Time: O(1) constant.
     * - Space: O(1) constant.
     * @returns {any} The top / last item of this stack.
     */
    peek() { 
        return this.items[this.items.length - 1];
    }

    /**
     * Returns whether or not this stack is empty.
     * - Time: O(1) constant.
     * - Space: O(1) constant.
     * @returns {boolean}

     */
    isEmpty() { 
        return this.items.length == 0;
    }

    /**
     * Returns the size of this stack.
     * - Time: O(1) constant.
     * - Space: O(1) constant.
     * @returns {number} The length.
     */
    size() { 
        return this.items.length;
    }
}

class Node {
    constructor(data) {
        this.data = data;
        this.next = null;
    }
}

// NOW IT'S YOUR TURN!!

class LinkedListStack {
    constructor() {
        this.head = null;
        this.length=0;
    }

    /**
     * Adds a new given item to the top / back of this stack.
     * - Time: O(?)
     * - Space: O(?)
     * @param {any} item The new item to be added to the top / back.
     * @returns {number} The new length of this stack.
     */
    push(item) { 
        
        if (this.isEmpty()){
            this.head = new Node(item)
            this.length +=1
            return this.length
        }
        let newHead = new Node(item)
        newHead.next = this.head
        this.head = newHead
        this.length+=1
        return this.length;
    }

    /**
     * Removes the top / last item from this stack.
     * - Time: O(?)
     * - Space: O(?)
     * @returns {any} The removed item or null if this stack was empty.
     */
    pop() { 
        if(this.isEmpty()){
            return null
        }
        let oldhead = this.head
        this.head = this.head.next
        this.length -=1
        return oldhead

    }

    /**
     * Retrieves the top / last item from this stack without removing it.
     * - Time: O(?)
     * - Space: O(?)
     * @returns {any} The top / last item of this stack or null if empty.
     */
    peek() { 
        return this.head
    }

    /**
     * Returns whether or not this stack is empty.
     * - Time: O(?)
     * - Space: O(?)
     * @returns {boolean}

     */
    isEmpty() { 
        return this.length==0;
    }

    /**
     * Returns the size of this stack.
     * - Time: O(?)
     * - Space: O(?)
     * @returns {number} The length.
     */
    size() { 
        return this.length
    }

    toArr() {
        const arr = [];
        let runner = this.head;

        while (runner) {
            arr.push(runner.data);
            runner = runner.next;
        }
        return arr;
    }
}


var stack1 = new LinkedListStack();
// console.log(stack1.isEmpty())
stack1.push(10)
// console.log(stack1.isEmpty())
stack1.push(11)
stack1.push(8)
console.log(stack1.toArr())
stack1.pop()
console.log(stack1.toArr())
console.log(stack1.peek().data)