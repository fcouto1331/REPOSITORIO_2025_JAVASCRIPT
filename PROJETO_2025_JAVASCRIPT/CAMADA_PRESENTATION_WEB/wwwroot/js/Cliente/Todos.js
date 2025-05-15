async function carregarClientes() {
    const response = await fetch('/Cliente/Todos', { method: 'POST' });
    if (!response.ok && response.status != 200) {
        alert('Erro na requisição');
        return;
    }
    const data = await response.json();

    console.log(response)
    console.log(data)

    const registros = document.getElementById('registros');
    registros.innerHTML = ''; 

    // Verifica se a resposta foi bem-sucedida
    if (data && data.ret) {
        const clientes = data.cliente;

        if (clientes && clientes.length > 0) {

            let tabela = '<table class="table table-bordered"><caption>Clientes</caption>';
            tabela += '<thead class="thead-dark"><tr><th class="w-25">ID</th><th>Nome</th></tr></thead><tbody>';

            // Adiciona as linhas dos clientes
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
}

// Opcional: chama automaticamente ao carregar a página
document.addEventListener('DOMContentLoaded', carregarClientes);