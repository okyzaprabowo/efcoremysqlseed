/*
Navicat MySQL Data Transfer

Source Server         : Localhost
Source Server Version : 50505
Source Host           : localhost:3306
Source Database       : example

Target Server Type    : MYSQL
Target Server Version : 50505
File Encoding         : 65001

Date: 2017-04-11 09:43:04
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `example`
-- ----------------------------
DROP TABLE IF EXISTS `example`;
CREATE TABLE `example` (
`ExampleId`  int(11) NOT NULL AUTO_INCREMENT ,
`ExampleDesc`  varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL ,
`ExampleName`  varchar(255) CHARACTER SET latin1 COLLATE latin1_swedish_ci NULL DEFAULT NULL ,
PRIMARY KEY (`ExampleId`)
)
ENGINE=InnoDB
DEFAULT CHARACTER SET=latin1 COLLATE=latin1_swedish_ci
AUTO_INCREMENT=4

;

-- ----------------------------
-- Records of example
-- ----------------------------
BEGIN;
INSERT INTO `example` VALUES ('1', 'Visit My Blog At okyzaprabowo.wordpress.com', 'John'), ('2', 'Visit My Blog At okyzaprabowo.wordpress.com', 'John'), ('3', 'Visit My Blog At okyzaprabowo.wordpress.com', 'John');
COMMIT;

-- ----------------------------
-- Auto increment value for `example`
-- ----------------------------
ALTER TABLE `example` AUTO_INCREMENT=4;
