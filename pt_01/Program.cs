//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


int getNumber(string massage){
    int number = 0;
    System.Console.WriteLine(massage);
    try {
         number = Convert.ToInt32(Console.ReadLine());
       
    }
    catch(Exception ex) {
        System.Console.WriteLine($"incorrect input {ex}");
    }
    return number;    
}

bool validateNum(int num){

    if (num < 10000 || num > 99999) return false;

    return true;

}

bool checkPolly(int[] arg){
    if(arg[0] == arg[4] && arg[1] == arg[3]) {
        System.Console.WriteLine("true");
        return true;
    } 
    System.Console.WriteLine("false");
    return false;
}

int[] numToArray(int arg){
    int[] nums = new int[5];
    for(int i = 0;i< nums.Length;i++){
        
        nums[i] = arg % 10;
        arg = arg / 10;              
          
         //System.Console.WriteLine($"nums i - {nums[i]}   arg - {arg}     i - {i} ");          
    }
    return nums;

}

int numFromUser = getNumber("enter 5 digit number");

if(validateNum(numFromUser)){
    checkPolly(numToArray(numFromUser));
}
else System.Console.WriteLine("invalid number !");





