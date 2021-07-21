function verificarContra() {
    var regex = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])\w{6,}$/;
    // Obtenemos los valores de los campos de contraseñas 
    pass1 = document.getElementById('TextPassreg');
    pass2 = document.getElementById('TextPass2reg');

    // Verificamos si las constraseñas no coinciden 
    if (pass1.value != pass2.value)
        pass2.setCustomValidity("Las contraseñas no coinciden");
    else
        if (regex.test(pass1.value)) {
            pass2.setCustomValidity("");
            window.location.href = "Default.aspx";
            return true;
        }
        else {
            pass2.setCustomValidity("La contraseña debe más de 6 caracteres, almenos una letra mayúscula y un dígito.");
            return false;
        }       
}
pass1.onchange = validatePassword;
pass2.onkeyup = validatePassword;