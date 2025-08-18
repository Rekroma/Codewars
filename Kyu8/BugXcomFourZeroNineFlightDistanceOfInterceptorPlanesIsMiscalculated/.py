def travel_distance(avg_speed, travel_time):
    KM_PER_NAUTICAL_MILE = 1.852
    travel_hours = travel_time / 60
    travel_nautical_miles = avg_speed * travel_hours
    travel_kms = travel_nautical_miles * KM_PER_NAUTICAL_MILE
    return travel_kms