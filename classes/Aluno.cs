namespace sistema_orientacao_a_objeto.classes
{
    public class Aluno
    {
        public string nome;
        public string curso;
        public int idade;
        public int rg;
        public bool bolsista;
        public float mediaFinal;
        public float valorMensalidade;

        public float VerMediaAluno(){
            return this.mediaFinal;
        }

        public float VerMensalidade(){
            float valor;
            
            if(this.bolsista){
                valor = this.valorMensalidade * 0.5f;
            } else {
                valor = this.valorMensalidade;
            }   

            return valor;
        }
        


    }
}