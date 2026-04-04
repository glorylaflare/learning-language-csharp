let balanceVisible = true;

function toggleBalance() {
    const balanceElement = document.getElementById('balance');
    const toggleIcon = document.getElementById('toggleIcon');

    if (balanceVisible) {
        balanceElement.classList.add('balance-hidden');
        toggleIcon.classList.remove('fa-eye');
        toggleIcon.classList.add('fa-eye-slash');
        balanceVisible = false;
    } else {
        balanceElement.classList.remove('balance-hidden');
        toggleIcon.classList.remove('fa-eye-slash');
        toggleIcon.classList.add('fa-eye');
        balanceVisible = true;
    }
}

function logout() {
    if (confirm('Tem certeza que deseja sair da sua conta?')) {
        window.location.href = '/Login/Login';
    }
}

function goToPayments() {
    window.location.href = '/Payment/Payment';
}