/**
 * Class to represent a queue using an array to store the queued items.
 * Follows a FIFO (First In First Out) order where new items are added to the
 * back and items are removed from the front.
 */
 class Queue {
    /**
     * The constructor is executed when instantiating a new Queue() to construct
     * a new instance.
     * @returns {Queue} This new Queue instance is returned without having to
     *    explicitly write 'return' (implicit return).
     */
    constructor() {
        this.items = [];
    }

    /**
     * Adds a new given item to the back of the queue and returns the new size of the queue
     * - Time: O(?)
     * - Space: O(?)
     * @param {any} item - The item to be added to the back of the queue
     * @returns {number} The new size of the queue
     */
    enqueue(item) {

    }

    /**
     * Removes the item from the front of the queue
     * - Time: O(n)
     * - Space: O(?)
     * @returns {any} The removed item or undefined if the queue was empty
     */
    dequeue() {

    }

    /**
     * Returns whether or not this queue is empty
     * - Time: O(?)
     * - Space: O(?)
     * @returns {boolean} Whether or not the queue is empty
     */
    isEmpty() {

    }

    /**
     * Returns the length of the queue
     * - Time: O(?)
     * - Space: O(?)
     * @returns {number} The length of the queue
     */
    size() {

    }

    /**
     * Retrieves the item at the front of the queue without removing it.
     * - Time: O(?)
     * - Space: O(?)
     * @returns {any} The item at the front of the queue
     */
    front() {

    }
}
