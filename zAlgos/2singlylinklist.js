/**
 * Creates a new node with the given data and inserts that node at the front
 * of this list.
 * - Time: (?).
 * - Space: (?).
 * @param {any} data The data for the new node.
 * @returns {SinglyLinkedList} This list.
 */
    insertAtFront(data) {
    var newNode = new Node(data);
    if(!this.head){
        this.head = newNode;
    }
    return this
    }

    }

    /**
  * Removes the first node of this list.
  * - Time: (?).
  * - Space: (?).
  * @returns {any} The data from the removed node.
  */
        removeHead() {}
    
 // EXTRA
 /**
  * Calculates the average of this list.
  * - Time: (?).
  * - Space: (?).
  * @returns {number|NaN} The average of the node's data.
  */
 average() {}