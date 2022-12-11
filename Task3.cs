class HelloWorld {
    static int[] degree (int a){
        Random rnd = new Random();
        int[] arr = new int[a];
        for (int i = 0; i < a; i++){
            arr[i] = rnd.Next();
        }
        return arr;
    }
  static void Main() {
    Console.WriteLine(degree(3));
  }
}