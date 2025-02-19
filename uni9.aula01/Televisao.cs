namespace aula_03;

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
        if(tamanho < TAMANHO_MINIMO){
            throw new ArgumentOutOfRangeException($"o tamanho ({tamanho})não é suportado.");
        }
        Tamanho = tamanho;
    }
    private const float TAMANHO_MINIMO = 22;

    // Get, permite que seja executado a leitura
    // do valor atual da propriedade
    // Set, permite que seja atribuido um
    // valor para propriedade

    // classes, propriedade e metodos possuem modificadores de acesso
    // eles são public:visiveis a todo o projeto
    // internal: visivel somente no namespace
    // protected: visiveis somente na classe e nas classses que herdam
    // private: visivel somente na classe que foram criadas
    public float Tamanho { get; private set; }
    public int Resolucao { get; set; }
    public int Volume { get; set; }
    public int Canal { get; set; }
    public bool Estado{ get; set; }
   

}