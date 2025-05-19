const criarCliente = () => {
    let _Nome = document.getElementById('Nome');
    if (validarFormulario()) alert('VALIDO')  
}

const validarFormulario = () => {
    if (!validarNome(document.getElementById('Nome'))) return false;
    return true;
}

const validarNome = (campo) => {

    let validarMensagem = campo.parentNode.querySelector('.validar-mensagem');
    if (validarMensagem) validarMensagem.remove();

    let span = document.createElement('span');
    span.className = 'validar-mensagem';
    span.style.color = 'red';

    // 1. Não permitir nulo ou vazio
    if (!campo.value || campo.value.trim() === "") {
        span.innerText = 'O campo é obrigatório.';
        campo.parentNode.appendChild(span);
        return false;
    }

    // 2. Máximo 200 caracteres
    if (campo.value.length > 100) {
        span.innerText = 'O campo deve ter no máximo 200 caracteres.';
        campo.parentNode.appendChild(span);
        return false;
    }

    // 3. Não permitir caracteres especiais (apenas letras, números e espaço)
    if (!/^[a-zA-Z0-9À-ÿ\s]+$/.test(campo.value)) {
        span.innerText = 'O campo não pode conter caracteres especiais.';
        campo.parentNode.appendChild(span);
        return false;
    }

    // Se passou por todas as validações
    return true;
}