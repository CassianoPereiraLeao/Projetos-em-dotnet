# Projeto de estacionamento

## Requisitos de projeto
- .NET Runtime
- .NET 9.0

### Models do projeto
- Estacionamento
    - Variáveis
        - Private initialValue | Variável local inteira
        - Private valuePerHour | Variavel local inteira
    - Métodos
        - void Run | Inicializa as variáveis da model e segura a função menu
        - void Menu | Loop principal da aplicação, loop do sistema
        - int PaymentValue | Retorna o valor a ser pago
- Veiculo
    - Variáveis
        - Private signs | Variavel local Lista de strings
    - Métodos
        - void ShowSigns | Mostra pro usuário as placas registradas no sistema
        - bool RemoveCar | Remove uma placa do sistema e retorna se funcionou ou não
        - void RegisterCar | Adiciona uma placa de carro no sistema
