const carregarTodosCliente = async () => {
    fetch('/Cliente/Todos', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        }
    })
        .then(response => response.json())
        .then(data => {
            const registros = document.getElementById('registros');
            registros.innerHTML = '';

            if (data && data.ret) {
                const clientes = data.cliente;
                if (clientes && clientes.length > 0) {
                    let tabela = '';
                    tabela += '<table class="table table-bordered"><caption>Clientes</caption>';
                    tabela += '<thead class="thead-dark"><tr><th class="w-25">ID</th><th>Nome</th></tr></thead><tbody>';

                    clientes.forEach(cliente => {
                        tabela += `<tr>
                            <td>${cliente.clienteId}</td>
                            <td>${cliente.nome ?? ''}</td>
                        </tr>`;
                    });

                    tabela += '</tbody></table>';
                    registros.innerHTML = tabela;
                } else {
                    registros.innerHTML = '<div>Nenhum cliente encontrado.</div>';
                }
            } else {
                registros.innerHTML = `<div class="text-danger">${data.output?.msg ?? 'Erro ao buscar clientes.'}</div>`;
            }
            console.log(data)
        })
        .catch(error => {
            alert(`${error}`)
        });
}

const abrirModalCriarCliente = () => {
    let modal = document.getElementById('modalCriarCliente');
    fetch('/html/Cliente/Criar.html')
        .then(response => {
            if (!response.ok) throw new Error('Erro ao carregar o formulário');
            return response.text();
        })
        .then(data => {
            modal.innerHTML = '';
            modal.innerHTML = data;
            var modalInstance = new bootstrap.Modal(modal);
            modalInstance.show();
        })
        .catch(error => {
            alert(`${error}`);
        });
}

// Opcional: chama automaticamente ao carregar a página
document.addEventListener('DOMContentLoaded', carregarTodosCliente);