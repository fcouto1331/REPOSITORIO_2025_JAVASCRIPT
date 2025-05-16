//const url = '/Cliente/Novo';
const url = '/Views/Cliente/_Novo.cshtml';

const abrirModalClienteNovo = () => {
    let modal = document.getElementById('modalClienteNovo');
    fetch(url, {
        method: 'GET'
    })
        .then(response => {
            if (!response.ok) throw new Error('Erro ao carregar o formulário');
            return response.text();
        })
        .then(data => {
            modal.innerHTML = '';
            modal.innerHTML = data;
            $('#modalClienteNovo').modal('show');
        })
        .catch(error => {
            alert(`${error}`)
        })
}