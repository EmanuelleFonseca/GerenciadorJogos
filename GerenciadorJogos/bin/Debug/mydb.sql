SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`jogo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`jogo` (
  `nome` VARCHAR(45) NOT NULL,
  `Tipo` VARCHAR(20) NOT NULL,
  `idJogo` INT NOT NULL AUTO_INCREMENT,
  `preco` DOUBLE NOT NULL,
  PRIMARY KEY (`idJogo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`venda`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`venda` (
  `idVenda` INT NOT NULL AUTO_INCREMENT,
  `valorTotal` VARCHAR(20) NOT NULL,
  `descricao` VARCHAR(500) NOT NULL,
  PRIMARY KEY (`idVenda`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
