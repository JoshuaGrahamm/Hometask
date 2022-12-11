static int Summ (int a){
        int sum = 0;
        while (a > 10){
            sum += a%10;
            a = a/10;
        }
        return sum+a;
}