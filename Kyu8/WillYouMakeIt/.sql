SELECT
  distance_to_pump,
  mpg,
  fuel_left,
  (fuel_left * mpg >= distance_to_pump) AS res
FROM zerofuel;