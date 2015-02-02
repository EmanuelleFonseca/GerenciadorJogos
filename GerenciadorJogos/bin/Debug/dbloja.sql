SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema dbloja
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `dbloja` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci ;
USE `dbloja` ;

-- -----------------------------------------------------
-- Table `dbloja`.`tbFuncionario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbloja`.`tbFuncionario` (
  `senhaFunc` VARCHAR(45) NOT NULL,
  `codFunc` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`codFunc`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `dbloja`.`tbProduto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbloja`.`tbProduto` (
  `idProduto` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `descricao` VARCHAR(140) NULL,
  `preco` DOUBLE NOT NULL,
  `quantidade` INT NOT NULL,
  `foto` VARCHAR(45) NULL,
  PRIMARY KEY (`idProduto`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `dbloja`.`tbNota`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbloja`.`tbNota` (
  `codFunc_fk` VARCHAR(45) NOT NULL,
  `idNota` INT NOT NULL AUTO_INCREMENT,
  `formaPg` VARCHAR(45) NOT NULL,
  `valorTotal` DOUBLE NOT NULL,
  `dataVenda` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idNota`, `codFunc_fk`),
  INDEX `fk_tbFuncionario_has_tbVinil_tbFuncionario_idx` (`codFunc_fk` ASC),
  CONSTRAINT `fk_tbFuncionario_has_tbVinil_tbFuncionario`
    FOREIGN KEY (`codFunc_fk`)
    REFERENCES `dbloja`.`tbFuncionario` (`codFunc`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `dbloja`.`tbItens`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `dbloja`.`tbItens` (
  `idProduto_fk` INT NOT NULL,
  `idNota_fk` INT NOT NULL,
  `quantidade` VARCHAR(45) NOT NULL,
  INDEX `fk_tbItens_tbVinil1_idx` (`idProduto_fk` ASC),
  PRIMARY KEY (`idProduto_fk`, `idNota_fk`),
  INDEX `fk_tbItens_venda1_idx` (`idNota_fk` ASC),
  CONSTRAINT `fk_tbItens_tbVinil1`
    FOREIGN KEY (`idProduto_fk`)
    REFERENCES `dbloja`.`tbProduto` (`idProduto`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_tbItens_venda1`
    FOREIGN KEY (`idNota_fk`)
    REFERENCES `dbloja`.`tbNota` (`idNota`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
