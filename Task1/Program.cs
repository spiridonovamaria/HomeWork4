//Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.


int[] Prompt(string message){     //Ввод чисел
    System.Console.WriteLine(message);
    int[] result = new int [2]; 
    string value = Console.ReadLine();
    result[0] = int.Parse(value);
    value = Console.ReadLine();
    result[1] = int.Parse(value);
    if (result[1]<1)
        throw new Exception ("Степень должна быть больше 0!");
    else 
        return result;
}

int  Exponentiation(int numberA, int numberB){
    int res = numberA;
    for (int i=1; i<numberB;i++){
        res *= numberA;
    }
    return res;
}

int[] term = Prompt("Введите число и степень: ");
int answer =  Exponentiation(term[0], term[1]);
Console.WriteLine(answer);