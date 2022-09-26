<!DOCTYPE html>
<!--
Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
Click nbfs://nbhost/SystemFileSystem/Templates/Project/PHP/PHPProject.php to edit this template
-->
<html>
    <head>
        <meta charset="UTF-8">
        <title></title>
    </head>
    <body>
        <?php
        class Bandat{
 
	// property class luas
	public $luas;	
 
 	// method pada class luas
	function luas($l){
		$this->luas=$l;
	}	
    }

class Keliling extends Bandat{
 
	// property class keliling
	public $keliling;
 
 	// method pada class keliling
	function keliling($kel){
		$this->keliling=$kel;
	}
}
$LuasdanKeliling = new Keliling;
 
 
$LuasdanKeliling->luas(" Menghitung Luas bangun datar ");
$LuasdanKeliling->keliling(" Menghitung Keliling bangun datar ");
 
// menampilkan isi property
echo "" . $LuasdanKeliling->luas . "<br/>";
echo "" . $LuasdanKeliling->keliling;
 
        ?>
    </body>
</html>
