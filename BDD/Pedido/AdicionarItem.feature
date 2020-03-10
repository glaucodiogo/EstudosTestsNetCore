Funcionalidade: Pedido - Adicionar Item ao Carrinho
	Como um usuário
	Eu desejo colocar um item  no carrinho
	Para que  eu possa compra-lo posteriormente

Cenario: Adicionar item com sucesso a um  novo pedido
Dado  que um produto esteja na vitrine
E Esteja disponível no estoque
E O usuário esteja logado
Quando O usuário adicionar uma unidade ao carrinho
Então O usuário  será redirecionado ao resumo da compra
E O valor total do pedido será exatamente o valor do item adicionado