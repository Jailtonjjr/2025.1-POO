using System.Formats.Asn1;

namespace aula_03;
// separação virtual 
class Televisao
{
    // o metodo construtr possui o mesmo
    // nome da classe. ele nao possui retorno
    // nem mesmo o void
    // este metodo é executado sempre que uma 
    // instancia da classe é criada
    // por padrao, o c# cria um metodo construtor publico vazil
    // mas podemos criar metodos construtores com outras
    // visibilidades e recebendo paramentros, se necessario.
    public Televisao(float tamanho)
    {
        if (tamanho < TAMANHO_MINIMO || tamanho > TAMANHO_MAXIMO)
        {
            // uma exceção interrompe o fluxo normal do sistema.
            throw new ArgumentOutOfRangeException($"o tamanho ({tamanho})não é suportado.");
        }
        Tamanho = tamanho;
        Volume = VOLUME_PADRAO;
        
    }
    // optamos pela utilização da constante s
    private const float TAMANHO_MINIMO = 22;
    private const float TAMANHO_MAXIMO = 100;

    private const int VOLUME_MAXIMO = 100;
    private const int VOLUME_MINIMO = 0;
    private const int VOLUME_PADRAO = 10;

    private int ultimoVolume = VOLUME_PADRAO;
    private bool ModoTroca = false;
    // Get, permite que seja executado a leitura
    // do valor atual da propriedade
    // Set, permite que seja atribuido um
    // valor para propriedade

    // classes, propriedade e metodos possuem modificadores de acesso
    // eles são public:visiveis a todo o projeto
    // internal: visivel somente no namespace
    // protected: visiveis somente na classe e nas classses que herdam
    // private: visivel somente na classe que foram criadas
    public float Tamanho { get;  }
    public int Resolucao { get; set; }
    public int Volume { get; private set; }
    public int Canal { get; set; }
    public bool Estado { get; set; }

    
    public void AumentarVolume()
    {
        if(ModoTroca == true){
            Console.WriteLine("A TV está no modo MUTE.");
        }
        else if (Volume < VOLUME_MAXIMO){ 
        Volume++;
    }
        else
        {
            Console.WriteLine("A tv já está no volume maximo permitido");
    }
    }

    public void DiminuirVolume()
    {
        if(ModoTroca == true){
            Console.WriteLine("A TV está no modo MUTE.");
        }
        else if (Volume > VOLUME_MINIMO){ 
        Volume--;
    }
        else
        {
            Console.WriteLine("A tv já está no volume minimo permitido");
    }


    }
    public void Silenciar()
        {
            ModoTroca = !ModoTroca;
            if(ModoTroca ==true){
                ultimoVolume = Volume;
                Volume = VOLUME_MINIMO;
                Console.WriteLine("Você colocou a TV está no modo MUTE.");
            }
            else{
                Volume = ultimoVolume;
                Console.WriteLine($"Você desmutou a TV, O volume da TV é : {Volume}.");

            }

            // if(Volume > VOLUME_MINIMO){
                
            //     ultimoVolume = Volume;
            //     Volume = VOLUME_MINIMO;
            //      Console.WriteLine("A TV está no modo MUTE.");
            // }
            // else{
            //     Volume = ultimoVolume;
            //      Console.WriteLine($"O volume da TV é : {Volume}.");

            // }
            

        }
}


