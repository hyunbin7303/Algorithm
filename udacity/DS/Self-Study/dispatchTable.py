

#We can dynamically define these keys based on whatever 
#we want and append those to the data-structure on whatever conditions and operations we need to support in our code.
class DispatchTable:
    table = {
        "alpha": run_alpha,
        "beta": run_betra,
        "gramma": run_gamma,
        "delta": run_delta
    }
    def run(self, version: str, data: bytes):
        return self.table[version](data)