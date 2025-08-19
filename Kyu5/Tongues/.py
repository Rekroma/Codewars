def tongues(code):
    pass
    vowels = "aiyeouAIYEOU"
    consonants = "bkxznhdcwgpvjqtsrlmfBKXZNHDCWGPVJQTSRLMF"
    
    def shift_char(c, sequence, shift):
        if c in sequence:
            idx = sequence.index(c)
            return sequence[(idx + shift) % len(sequence)]
        return c
    
    decoded_text = "".join(
        shift_char(c, vowels, 3) if c in vowels else shift_char(c, consonants, 10) for c in code
    )
    
    def preserve_case(original, transformed):
        return "".join(t.upper() if o.isupper() else t.lower() for o, t in zip(original, transformed))
    
    return preserve_case(code, decoded_text)