<title>Custom validator </title>
<script language="javascript">
    function check(sender e){
        if(isNan(e.valueOf)){
            document.writeLine("Inavlid id");
        }else{
            document.writeLine("valid id");
        }
    }
</script>
<asp: customValidator Id="" runat="server" errorMessage="InvalidId" ControlValidate="TextBox2"></asp:CustomValidatorID>
