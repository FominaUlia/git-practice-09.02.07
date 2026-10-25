HEAD
// Функция сложения
int Add(int a, int b) {
    return a + b;
// Функция умножения
int Multiply(int a, int b) {
    return a * b;
feature/calculator-advanced
}

// Функция деления
int Divide(int a, int b) {
    if (b == 0) {
        throw new System.DivideByZeroException("Деление на ноль невозможно");
    }
    return a / b;
}
