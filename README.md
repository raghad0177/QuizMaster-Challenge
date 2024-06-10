# QuizMaster-Challenge

## Purpose of the Program
The program is a simple quiz application designed to test users on their knowledge of various facts. It presents a series of True/False questions to the user and evaluates their responses, calculating a score based on the number of correct answers.

## Instructions on How to Run the Program

1. **Compile the Program**:
    - Save the code in a file named `Program.cs`.
    - Open a command line or terminal and navigate to the directory containing `Program.cs`.
    - Compile the program using the C# compiler by running:
      ```bash
      csc Program.cs
      ```
    - This will generate an executable file named `Program.exe`.

2. **Run the Program**:
    - Execute the compiled program by running:
      ```bash
      Program.exe
      ```
    - The program will start and display a series of True/False questions.

3. **Answer the Questions**:
    - For each question, type `T` for True or `F` for False and press Enter.
    - The program will inform you if your answer is correct or incorrect.
    - If an invalid input is provided, the program will prompt you to enter a valid response.

4. **Completion**:
    - After all questions have been answered, the program will display your total score out of 25.
    - The program will then display the message "The Exam Finished."

## Additional Information or Notes

- **Error Handling**:
  - The program includes basic error handling to catch and display any exceptions that might occur during execution.
  - If a `FormatException` or any other exception occurs, it will be caught, and the exception message will be displayed.
  - The program ensures the user inputs either 'T' or 'F' for each question. If an invalid response is given, the user is prompted to try again.

- **Question and Answer Storage**:
  - The questions and answers are stored in a two-dimensional array `QustAndAns`.
  - Each question is paired with its correct answer ('T' for True and 'F' for False).

- **Scoring**:
  - The score is incremented by 5 points for each correct answer.
  - The maximum possible score is 25 points, as there are 5 questions.

- **Namespace and Class**:
  - The code is encapsulated within the namespace `QuizMaster_Challenge`.
  - The entry point of the program is the `Main` method in the `Program` class.

## Example Output
```plaintext
Sharks are mammals?(True/False)
F
Right Answer
The blue whale is the biggest animal to have ever lived?(True/False)
T
Right Answer
Bats are blind?(True/False)
F
Right Answer
Pigs roll in the mud because they don't like being clean?(True/False)
F
Right Answer
Infants have more bones than adults?(True/False)
T
Right Answer
Your Score is : 25/25
The Exam Finished.
