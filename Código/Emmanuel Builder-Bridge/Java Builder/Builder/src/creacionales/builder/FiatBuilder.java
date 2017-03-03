package creacionales.builder;

public class FiatBuilder extends AutoBuilder{

	 public void buildMarca(){
	        auto.setMarca("Fiat");
	    }
	    
	    public void buildModelo(){
	        auto.setModelo("Palio");
	    }
	    
	  
	    public void buildMotor(){
	        Motor motor = new Motor();
	        motor.setNumero(232323);
	        motor.setPotencia("23 HP");
	        auto.setMotor(motor);
	    }
	    
	    public void buildPuertas(){
	        auto.setCantidadDePuertas(2);
	    }
}
