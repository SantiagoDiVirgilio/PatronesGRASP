public class Empleado {
    private String nombre;
    private double salarioBase;
    private double horasExtras;
    private double tasaDeImpuestos;

    public Empleado(String nombre, double salarioBase, double horasExtras, double tasaDeImpuestos) {
        this.nombre = nombre;
        this.salarioBase = salarioBase;
        this.horasExtras = horasExtras;
        this.tasaDeImpuestos = tasaDeImpuestos;
    }

    public double calcularSalarioNeto() {
        // Cálculo del salario bruto
        double salarioBruto = this.salarioBase + (this.horasExtras * 25.0);

        // Cálculo de los impuestos
        double impuestos = salarioBruto * this.tasaDeImpuestos;

        // Retorno del salario neto
        return salarioBruto - impuestos;
    }

    public void mostrarDetallesSalario() {
        System.out.println("--- Detalles de Salario de " + this.nombre + " ---");
        System.out.println("Salario Base: $" + this.salarioBase);
        System.out.println("Horas Extras: " + this.horasExtras);
        System.out.println("Salario Neto: $" + this.calcularSalarioNeto());
        System.out.println("------------------------------------");
    }

    public static void main(String[] args) {
        // Creamos una instancia del empleado con sus datos.
        Empleado juan = new Empleado("Juan Pérez", 50000.0, 10.0, 0.15);
        Empleado ana = new Empleado("Ana Gómez", 65000.0, 5.0, 0.20);

        juan.mostrarDetallesSalario();
        ana.mostrarDetallesSalario();
    }
}