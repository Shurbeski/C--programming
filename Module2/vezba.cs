class Program {

    public void Sortirac(int[] broevi, char[] bukvi) {
        var parni = new int[6];
        var samoglaski = new char [4];
        int brojachNizaBroevi = 0;
        int brojachNizaKarakteri = 0;

        for (int i = 0; i < broevi.Length; i++) {
            if (broevi[i] % 2 == 0) { 
                parni[brojachNizaBroevi] = broevi[i];
                brojachNizaBroevi++;
            }
        }
        for (int i = 0; i < bukvi.Length; i++)
        {
            if (bukvi[i] == 'a' || bukvi[i] == 'e' || bukvi[i] == 'i' || bukvi[i] == 'o' || bukvi[i] == 'u') {
                samoglaski[brojachNizaKarakteri] = bukvi[i];
                brojachNizaKarakteri++;
            }
        }
        int iteratorBrojki = 0;

        while (iteratorBrojki < parni.Length) {
            Console.WriteLine(parni[iteratorBrojki]);
            iteratorBrojki++;
        }

        int iteratorKarakteri = 0;

        while (iteratorKarakteri < samoglaski.Length)
        {
            Console.WriteLine(samoglaski[iteratorKarakteri]);
            iteratorKarakteri++;
        }

    } 

    public static void Main(string[] args)
    {
        int[] ints = { 22, 3, 16, 5 ,9, 0, 166, 188, 187, 22, 45}; //Parni izvadi i stavi gi vo posebna niza
        char[] chars = { 'b', 'a', 'f', 'r', 'e' }; //Samoglaski izvadi i stavi gi vo posebna niza

        Program p1 = new Program();
        p1.Sortirac(ints, chars);
    }
}
