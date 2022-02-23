<script>
    function printFun(test) 
    {
        if (test<1)
            return;
        else {
            document.write(test+" ");
            printFun(test-1);
            document.write(test +" ");
            return;
        }
        
    }
    let test =3;
    printFun(test);
</script>