static int degree (int a, int b){
        int A = a;
        for(int i=1; i<b; i++){
            A*=a;
        }
        return A;
}