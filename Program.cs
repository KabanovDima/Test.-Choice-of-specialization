// Написать программу, которая из имеющего массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа

string[] array = {"hello", "2", "word", "my", "-2", "0"};
string[] array1 = new string[array.Length];
void StringLengthLessThree(string[] array, string[] array1){
    int count = 0;
    for (int i = 0; i < array.Length; i++){
        if(array[i].Length <= 3){
            array1[count] = array[i];
            count++;
        }
    }
}
void PrintArray(string[] array){
    for (int i = 0; i < array.Length; i++){
        System.Console.Write($"{array1[i]} ");
    }
}
StringLengthLessThree(array, array1);
PrintArray(array1);