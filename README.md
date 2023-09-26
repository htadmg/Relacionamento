# Projeto de Relacionamento de Modelos e Carros

Este projeto implementa um sistema de relacionamento entre modelos de carros e carros individuais usando Entity Framework.

## Estrutura do Projeto

O projeto é dividido em três classes principais:

### 1. BaseContext

A classe `BaseContext` é uma extensão do DbContext do Entity Framework e define a configuração do banco de dados e as propriedades DbSet para os modelos e carros.

### 2. Carro

A classe `Carro` representa um carro individual e possui os seguintes atributos:

- `Id`: Identificador único do carro.
- `ModeloId`: Chave estrangeira que referencia o modelo ao qual o carro pertence.
- `Modelo`: Propriedade de navegação que representa o modelo associado ao carro.
- `Nome`: Nome do carro.
- `Ano`: Ano de fabricação do carro.

Além disso, a classe possui métodos para salvar um novo carro no banco de dados e para retornar uma lista de todos os carros cadastrados.

### 3. Modelo

A classe `Modelo` representa um modelo de carro e possui os seguintes atributos:

- `Id`: Identificador único do modelo.
- `Nome`: Nome do modelo.
- `Carros`: Lista de carros associados a este modelo.

Assim como na classe `Carro`, a classe `Modelo` possui métodos para salvar um novo modelo no banco de dados e para retornar uma lista de todos os modelos cadastrados.

## Utilização

Para utilizar este projeto, siga os passos abaixo:

1. Crie uma instância do contexto de banco de dados `BaseContext`.
2. Utilize os métodos da classe `Carro` e `Modelo` para realizar operações de salvamento e consulta.

Exemplo:

```csharp
var db = new BaseContext();

// Criar e salvar um novo modelo
var novoModelo = new Modelo() { Nome = "Novo Modelo" };
novoModelo.Salvar();

// Criar e salvar um novo carro associado ao modelo criado
var novoCarro = new Carro() { Nome = "Novo Carro", Modelo = novoModelo, Ano = 2023 };
novoCarro.Salvar();

// Consultar todos os carros
var carros = Carro.Todos();
