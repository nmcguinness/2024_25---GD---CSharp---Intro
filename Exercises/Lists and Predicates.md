
## Exercises - Lists and Predicates

### Exercise 1: Managing Player List
**Description**: Create a list of `Player` objects and populate it with 5 different players. Then, write a method to filter out inactive players using a Predicate. Display the remaining active players using the `ToString()` method.

**Difficulty:** Easy

**Hint**: Use `List<Player>.FindAll()` and pass a Predicate that checks if the player is active.

---

### Exercise 2: Finding a Player by ID 
**Description**: Create a list of `Player` objects and populate it with multiple players. Write a method that takes a string as input and returns the player with the matching ID using a Predicate. If no player is found, return null.

**Difficulty:** Easy

**Hint**: Use `List<Player>.Find()` and pass a Predicate that checks for a matching ID.

---

### Exercise 3: Sorting Players by Health 
**Description**: Create a list of `Player` objects and populate it with players having different health values. Write a method to sort the players by health (descending order) and display the sorted list using the `ToString()` method.

**Difficulty:** Medium

**Hint**: Use `List<Player>.Sort()` with a comparison delegate.

---

### Exercise 4: Filtering Players by Health Range 
**Description**: Create a list of `Player` objects with various health values. Write a method to filter out players whose health is below a given threshold using a Predicate. Display the list of players with health above the threshold.

**Difficulty:** Medium

**Hint**: Use `List<Player>.FindAll()` and pass a Predicate that checks if the player's health is above the threshold.

---

### Exercise 5: Finding the Fastest Player 
**Description**: Create a list of `Player` objects with varying `moveSpeed` values. Write a method that finds the player with the highest move speed using a Predicate. Display that player's information using the `ToString()` method.

**Difficulty:** Medium

**Hint**: Use `List<Player>.Find()` with a Predicate that checks for the maximum move speed.

---
