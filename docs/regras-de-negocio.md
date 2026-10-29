# Regras de Negócio — Lanchonete Senac

## RN01 — Cardápio
O sistema deve apresentar cinco produtos: Coxinha, Pão de queijo, Suco, Café e Bolo, cada um com seu respectivo preço.

## RN02 — Dias de funcionamento
O sistema deve controlar as vendas de segunda-feira a sexta-feira.

## RN03 — Identificação dos produtos e dias
O usuário deve selecionar o produto e o dia da semana por meio de códigos de 1 a 5. Internamente, os índices dos vetores e da matriz começam em 0.

## RN04 — Registro de venda
Para registrar uma venda, o sistema deve receber o código do produto, o código do dia da semana e a quantidade vendida.

## RN05 — Validação da venda
O sistema deve aceitar somente códigos válidos de produtos e dias, além de quantidades maiores que zero. Caso os dados sejam inválidos, deve exibir uma mensagem de erro.

## RN06 — Acumulação das vendas
Ao registrar uma nova venda, o sistema deve adicionar a quantidade informada à quantidade já registrada para o mesmo produto e dia, sem substituir o valor anterior.

## RN07 — Total de vendas por produto
O sistema deve calcular a quantidade total vendida de cada produto durante a semana, somando as vendas dos cinco dias.

## RN08 — Total de vendas por dia
O sistema deve calcular a quantidade total de itens vendidos em cada dia da semana, somando as vendas de todos os produtos.

## RN09 — Faturamento por produto
O sistema deve calcular o faturamento de cada produto multiplicando a quantidade total vendida pelo seu preço unitário.

## RN10 — Faturamento semanal
O sistema deve calcular o faturamento total da semana somando o faturamento de todos os produtos.

## RN11 — Produto mais vendido
O sistema deve identificar o produto com a maior quantidade total de unidades vendidas durante a semana.

## RN12 — Dia mais movimentado
O sistema deve identificar o dia da semana com a maior quantidade total de itens vendidos.

## RN13 — Menu principal
O sistema deve apresentar um menu com as opções de visualizar o cardápio, registrar vendas, consultar o relatório por produto, consultar o relatório por dia, visualizar o resumo semanal e sair do programa.

## RN14 — Navegação do sistema
Após executar uma operação, o sistema deve retornar ao menu principal, permitindo que o usuário realize outras operações até selecionar a opção de saída.

## RN15 — Tratamento de entradas inválidas
O sistema deve apresentar mensagens de erro para códigos inválidos de produto ou dia e para quantidades iguais a zero ou negativas, sem encerrar o programa nem alterar os dados de vendas.

## RN16 — Resumo semanal
O resumo semanal deve apresentar o faturamento total, o produto mais vendido e o dia mais movimentado.
