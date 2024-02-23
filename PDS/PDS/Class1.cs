using System;
 class cadastro
{
    public string Cnpj { get; set; }
    public string RazaoSocial { get; set; }
    public string NomeFantasia { get; set; }
    public string SituacaoCadastral { get; set; }
    public string Telefone { get; set; }
    public string DataInicioAtividade { get; set; }
    public string CapitalSocial { get; set; }
    public string Estado { get; set; }
    public string NaturezaJuridica { get; set; }
    public string Cidade { get; set; }
    public string Bairro { get; set; }
    public string Rua { get; set; }
    public string Nome { get; set; }
    public string Cpf { get; set; }

    public cadastro()
    {

    }
    public cadastro(string cnpj, string razaoSocial, string nomeFantasia, string situacaoCentral, string telefone, string dataInicioAtividade,
        string capitalSocial, string estado, string naturezaJuridica, string cidade, string bairro, string rua, string nome, string cpf)
    {
        this.Cnpj = cnpj;
        this.RazaoSocial = razaoSocial;
        this.NomeFantasia = nomeFantasia;
        this.SituacaoCadastral = telefone;
        this.Telefone = telefone;
        this.DataInicioAtividade = dataInicioAtividade;
        this.CapitalSocial = capitalSocial;
        this.Estado = estado;
        this.NaturezaJuridica = naturezaJuridica;
        this.Cidade = cidade;
        this.Bairro = bairro;
        this.Rua = rua;
        this.Nome = nome;
        this.Cpf = cpf;
    }
}

