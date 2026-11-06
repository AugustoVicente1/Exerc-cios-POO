// string Nome= "Augusto";

using EcxercíciosPOO;

// Pessoa p1 = new Pessoa();

// p1.Nome = "Augusto";
// p1.Idade = 20;  
// p1.Cidade = "São Paulo";

// p1.Apresentar();

// Calculadora c1 = new Calculadora();
// c1.Somar(10, 5);
// Calculadora.Dividir(10, 5);

// Veiculo v1 = new Veiculo();
// v1.Velocidade = 2000; 

Funcionario f1 = new Funcionario();


f1.Nome = "Thiago";
f1.Cargo = "TI";
decimal salario = f1.ConsultarSalario();
f1.AumentarSalario();
salario = f1.ConsultarSalario();
Console.WriteLine($"O salário de {f1.Nome} é: {salario}");