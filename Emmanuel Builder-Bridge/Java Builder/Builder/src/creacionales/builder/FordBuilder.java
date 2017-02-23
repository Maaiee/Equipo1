package creacionales.builder;

public class FordBuilder extends AutoBuilder {
	
	public void buildMarca(){
        auto.setMarca("Ford");
    }
    
    public void buildModelo(){
        auto.setModelo("Focus");
    }
    
  
    public void buildMotor(){
        Motor motor = new Motor();
        motor.setNumero(21212);
        motor.setPotencia("20 HP");
        auto.setMotor(motor);
    }
    
    public void buildPuertas(){
        auto.setCantidadDePuertas(4);
    }

}
