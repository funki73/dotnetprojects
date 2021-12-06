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
    }
    /**
     * Adds a new given item to the top / back of this stack.
     * - Time: O(?)
     * - Space: O(?)
     * @param {any} item The new item to be added to the top / back.
     * @returns {number} The new length of this stack.
     */
    push(item) {

        // create new node temp and allocate memory
        let temp = new Node();
        
        // check if stack (heap) is full. Then inserting an
        //  element would lead to stack overflow
        if (temp == null) {
            document.write("<br>Heap Overflow");
            return;
        }
        
        // initialize data into temp data field
        temp.data = item;
        
        // put top reference into temp link
        temp.link = this.head;
        
        // update top reference
        this.head = temp;
    }
        isEmpty()
    {
        return this.head == null;
    }

    /**
     * Removes the top / last item from this stack.
     * - Time: O(?)
     * - Space: O(?)
     * @returns {any} The removed item or null if this stack was empty.
     */
    pop() { }

    /**
     * Retrieves the top / last item from this stack without removing it.
     * - Time: O(?)
     * - Space: O(?)
     * @returns {any} The top / last item of this stack or null if empty.
     */
    peek() { }

    /**
     * Returns whether or not this stack is empty.
     * - Time: O(?)
     * - Space: O(?)
     * @returns {boolean}

     */
    isEmpty() { }

    /**
     * Returns the size of this stack.
     * - Time: O(?)
     * - Space: O(?)
     * @returns {number} The length.
     */
    size() { }
}