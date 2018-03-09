function validate()
{
    var user = document.forms[0];
    if(document.forms[0].name.value=="jay"&&document.forms[0].password.value==123)
    {
        document.getElementById("label1").style.display = 'none';
        document.getElementById("a1").style.display = 'block';
        user.name.value = '';
        user.password.value = '';
        document.getElementById("b1").style.display = 'none';
    }
    else
    {
        document.getElementById("a1").style.display = 'none';
        document.getElementById("label1").style.display = 'block';
    }
}