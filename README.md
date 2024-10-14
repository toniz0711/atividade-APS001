# Simulador de Computador

Este projeto simula a montagem de um computador, permitindo a adição de diversos componentes, como placas-mãe, processadores, fontes, placas de vídeo, SSDs e memória RAM.

## Funcionalidades

- Adicionar componentes ao computador.
- Exibir informações detalhadas sobre cada componente.

## Estrutura do Código

O código é estruturado em várias classes que representam os componentes do computador:

- **Computador**: Classe principal que gerencia os componentes.
- **Componente_base**: Classe base para todos os componentes, contendo propriedades comuns como voltagem, potência e modelo.
- **Processador**: Classe derivada que adiciona propriedades específicas para processadores, como frequência e cache.
- **Placa_mae**: Classe que representa a placa-mãe.
- **Fonte**: Classe que representa a fonte de alimentação, incluindo a voltagem.
- **Ssd**: Classe para representar um SSD, incluindo a capacidade em gigabytes.
- **Ram**: Classe para representar a memória RAM, incluindo a capacidade em gigabytes.
- **Placa_Video**: Classe para representar a placa de vídeo, incluindo a memória de vídeo.

## Como Usar

1. Clone o repositório:
   ```bash
   git clone <URL do repositório>
```cSharp
Computador pc = new Computador();
Placa_mae mobo = new Placa_mae(12, 15, "ASUS");
pc.Adicionar_Componete(mobo);
Processador i5 = new Processador(12, 15, "Intel i5", 2.6, 1);
pc.Adicionar_Componete(i5);
Fonte fonte650 = new Fonte(12, 15, "Normal", 650);
pc.Adicionar_Componete(fonte650);
Placa_Video rtx = new Placa_Video(12, 15, "NVIDIA RTX 4060", 8);
pc.Adicionar_Componete(rtx);
Ssd samdisk = new Ssd(12, 15, "SamDisk", 600);
pc.Adicionar_Componete(samdisk);
Ram pichau = new Ram(12, 15, "Pichau", 32);
pc.Adicionar_Componete(pichau);
```
### Como Personalizar

- **URL do repositório**: Substitua `<URL do repositório>` pela URL real do seu repositório.
- **Licença**: Se você tiver uma licença específica, atualize as informações da seção de licença.

Se precisar de mais ajustes ou informações, é só avisar!
