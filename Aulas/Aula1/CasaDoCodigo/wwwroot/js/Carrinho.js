class Carrinho {
    clickAddProduto(btn) {
        let data = this.getData(btn);
        data.Quantidade++;
        this.postQuantidade(data);
       
    }

    clickRemoveProduto(btn) {
        let data = this.getData(btn);
        data.Quantidade--;
        this.postQuantidade(data);
    }

    updateQuantidade(input) {
        let data = this.getData(input);
        this.postQuantidade(data);
    }

    getData(elemento) {
        var linhaDoItem = $(elemento).parents('[item-id]');
        var itemId = $(linhaDoItem).attr('item-id');
        var novaQtde = $(linhaDoItem).find('input').val();

        return {
            Id: itemId,
            Quantidade: novaQtde
        };
    }

    postQuantidade(data) {
        $.ajax({
            url: '/pedido/updatequantidade',
            type: 'POST',
            contentType: 'application/json',
            data: JSON.stringify(data)
        }).done(function (response) {
            
        });
    }
}


var carrinho = new Carrinho();